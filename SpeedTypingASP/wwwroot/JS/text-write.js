var inputField = document.getElementById('text-input-field');
var correctStringTextbox = document.getElementById('actual-correct-string-textbox');

var inputString = correctStringTextbox.innerHTML;
var correctStrings = [];
var currentIdOfCurrentString = 0;

var subCounter = 0;
var startOfString = 0;
for (var i = 0; i < inputString.length; i++, subCounter++) {
    if (inputString[i] === '\n') {
        correctStrings[correctStrings.length++] = inputString.substring(startOfString, i - 1);
        startOfString = i + 1;
        subCounter = 0;
    }
    if (subCounter === 100) {
        correctStrings[correctStrings.length++] = inputString.substring(startOfString, i);
        startOfString = i + 1;
        subCounter = 0;
    }
}
if(subCounter > 1)
    correctStrings[correctStrings.length++] = inputString.substring(startOfString, inputString.length);


var correctString;
UpdateActualCorrectString();

var hasError = false;

function UpdateActualCorrectString() {
    correctString = correctStrings[currentIdOfCurrentString++];
    if (currentIdOfCurrentString > correctStrings.length) {
        currentIdOfCurrentString = 0;
        UpdateActualCorrectString();
    }
    correctStringTextbox.innerHTML = correctString;
}

function validateInputField() {
    let substringedCorrectStr = correctString.substring(0, inputField.value.length);
    let value = inputField.value;

    if (substringedCorrectStr !== value) {
        if (hasError)
            return;
        var lastChar = value[value.length - 1];
        if (lastChar == ' ') {
            var substringedValue = value.substring(0, value.length - 1);
            if (substringedValue === correctString) {
                inputField.value = '';
                UpdateActualCorrectString();
                return;
            }
        }
        inputField.style.borderColor = 'red';
        inputField.style.backgroundColor = 'rgba(255, 0, 0, .4)';
        hasError = true;
    }
    else if (hasError) {
        inputField.style.borderColor = '#9BA1F2';
        inputField.style.backgroundColor = 'transparent';
        hasError = false;
    }
}

$('#text-input-field').on('keyup', function (e) {
    if (e.keyCode == 13) {
        inputField.value += ' ';
        validateInputField();
    }
});
$('#text-input-field').on('input', function (e) {
    validateInputField();
});