let popupCharacterCountElem = document.getElementById('text-selection__popup-character-count');
let popupSliderElem = document.getElementById('text-selection__popup-slider');
let fullSizeCharacters = 0;
setSliderValue('3');

function setSliderValue(value) {
    popupSliderElem.value = value;
    UpdateSize(value);
}
function SetFullSize(countOfCharacters) {
    fullSizeCharacters = countOfCharacters;
}

function UpdateSize(value) {
    let textSizeStr = 'Размер текста: ';
    let currentSize = 0;
    switch (value) {
        case '1':
            textSizeStr += 'ultra short - 50';
            break;
        case '2':
            currentSize = Math.floor(fullSizeCharacters * .25);
            textSizeStr += `short (25%) - ${currentSize}`;
            break;
        case '3':
            currentSize = Math.floor(fullSizeCharacters * .5);
            textSizeStr += `medium (50%) - ${currentSize}`;
            break;
        case '4':
            currentSize = Math.floor(fullSizeCharacters * .75);
            textSizeStr += `large (75%) - ${currentSize}`;
            break;
        case '5':
            textSizeStr += `full (100%) - ${fullSizeCharacters}`;
            break;
    }
    popupCharacterCountElem.innerHTML = textSizeStr;
}
function GetSliderValue() {
    return popupSliderElem.value;
}