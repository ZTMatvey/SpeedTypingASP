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
        startOfString = i;
        subCounter = 0;
    }
    if (subCounter === 100) {
        correctStrings[correctStrings.length++] = inputString.substring(startOfString, i);
        startOfString = i;
        subCounter = 0;
    }
}
if (subCounter > 1)
    correctStrings[correctStrings.length++] = inputString.substring(startOfString, inputString.length);

for (var i = 0; i < correctStrings.length; i++) {
    var startFlag = false;
    var endFlag = false;

    while (true) {
        if (correctStrings[i].length > 0) {
            var currentString = correctStrings[i];
            if (currentString[0] === ' ' ||
                currentString[0] === '\n')
                correctStrings[i] = currentString.substring(1, currentString.length);
            else
                startFlag = true;
            if (currentString[currentString.length - 1] === ' ' ||
                currentString[currentString.length - 1] === '\n')
                correctStrings[i] = currentString.substring(0, currentString.length - 1);
            else
                endFlag = true;
        } else {
            correctStrings.splice(i--, 1);
            break;
        }
        if (startFlag && endFlag)
            break;
    }
}

var correctString;
UpdateActualCorrectString();

var hasError = false;

function UpdateActualCorrectString() {
    correctString = correctStrings[currentIdOfCurrentString++];
    if (correctStrings.length === 0) {
        document.location.href = "/";
        return;
    }
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