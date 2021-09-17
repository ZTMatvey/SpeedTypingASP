var inputField = document.getElementById('text-input-field');
var correctStringTextbox = document.getElementById('actual-correct-string-textbox');
var timerInfoWrapper = document.getElementById('text-write__timer-info-wrapper');
var textTitleElement = document.getElementById('text-write__text-title');
var textSizeElement = document.getElementById('text-write__TextSize');

NormalInTextWrite();
inputField.focus();

var inputString = correctStringTextbox.innerHTML;
var correctStrings = [];
var currentIdOfCurrentString = 0;

var countOfErrors = 0;
var countOfCorrects = 0;
var lastStr = '';
var maxCountOfCorrectsInLine = 0;

var textChanged = TextChangedFirst;

var subCounter = 0;
var startOfString = 0;
for (var i = 0; i < inputString.length; i++, subCounter++) {
    if (inputString[i] === '\n') {
        correctStrings[correctStrings.length++] = inputString.substring(startOfString, i - 1);
        startOfString = i;
        subCounter = 0;
    }
    let isSpaceOrTab = inputString[i] === ' ' || inputString[i] === '\t';
    let firstCondition = subCounter >= 75 && isSpaceOrTab;
    let secondCondition = subCounter >= 125;
    if (firstCondition || secondCondition) {
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

function ErrorInTextWrite() {
    RemoveAllNonMainClassesFromTextBox();
    inputField.classList.add('text-write__text-box-error');
}
function NormalInTextWrite() {
    RemoveAllNonMainClassesFromTextBox();
    inputField.classList.add('text-write__text-box-normal');
}
function AllCorrectInTextWrite() {
    RemoveAllNonMainClassesFromTextBox();
    inputField.classList.add('text-write__text-box-all-correct');
}
function SendFormRequestOfEnd() {
    const form = document.getElementById('text-write__resultForm');

    form.setAttribute('action', `/Home/TextWriteResult?textSize=${textSizeElement.value}&textTitle=${textTitleElement.value}&countOfErrors=${countOfErrors}&countOfCorrects=${countOfCorrects}&time=${GetNumTime()}`);

    form.submit();
}

function RemoveAllNonMainClassesFromTextBox() {
    if (inputField.classList.contains('text-write__text-box-normal'))
        inputField.classList.remove('text-write__text-box-normal');
    if (inputField.classList.contains('text-write__text-box-error'))
        inputField.classList.remove('text-write__text-box-error');
    if (inputField.classList.contains('text-write__text-box-all-correct'))
        inputField.classList.remove('text-write__text-box-all-correct');
}

function UpdateActualCorrectString() {
    correctString = correctStrings[currentIdOfCurrentString++];
    if (correctStrings.length === 0) {
        ToHomePage();
        return -1;
    }
    if (currentIdOfCurrentString > correctStrings.length) {
        currentIdOfCurrentString = 0;
        correctStringTextbox.innerHTML = '';
        AllCorrectInTextWrite();
        //inputField.style.borderColor = 'green';
        //inputField.style.backgroundColor = 'rgba(0, 255, 0, .4)';
        return 0;
        UpdateActualCorrectString();
    }
    correctStringTextbox.innerHTML = correctString;
    lastStr = '';
    maxCountOfCorrectsInLine = 0;
    return 1;
}

function Reload() {
    location.reload();
}
function ToHomePage() {
    location.href = "/";
}

function StopInput() {
    StopTimer();
    StopCpmTimer();
    MakeTimerGreen();
}

function validateInputField(isAdded) {
    let substringedCorrectStr = correctString.substring(0, inputField.value.length);
    let value = inputField.value;

    if (substringedCorrectStr !== value) {
        if (isAdded)
            countOfErrors++;
        if (hasError)
            return;
        var lastChar = value[value.length - 1];
        if (lastChar == ' ') {
            var substringedValue = value.substring(0, value.length - 1);
            if (substringedValue === correctString) {
                countOfErrors--;
                inputField.value = '';
                let result = UpdateActualCorrectString();
                if (result === 0) {
                    StopInput();
                    SendFormRequestOfEnd();
                }
                return;
            }
        }
        ErrorInTextWrite();
        //inputField.style.borderColor = 'red';
        //inputField.style.backgroundColor = 'rgba(255, 0, 0, .4)';
        hasError = true;
    }
    else if (hasError) {
        NormalInTextWrite();
        //inputField.style.borderColor = '#9BA1F2';
        //inputField.style.backgroundColor = 'transparent';
        hasError = false;
    } else if (value.length > maxCountOfCorrectsInLine) {
        maxCountOfCorrectsInLine++;
        countOfCorrects++;
        correctInLastPartOfTime++;
    }
}
function TextChangedFirst() {
    textChanged = TextChanged;
    StartTimer();
    StartCpmTimer();
    TextChanged();
}
function TextChanged() {
    let symbAdded;
    if (lastStr === '')
        symbAdded = true;
    else
        symbAdded = inputField.value.includes(lastStr);
    validateInputField(symbAdded);
    lastStr = inputField.value;
}


$('#text-input-field').on('keyup', function (e) {
    if (e.keyCode == 13) {
        inputField.value += ' ';
        textChanged();
    }
});
$('#text-input-field').on('input', function (e) {
    textChanged();
});