let popupCharacterCountElem = document.getElementById('text-selection__popup-character-count');
let popupSliderElem = document.getElementById('text-selection__popup-slider');
setSliderValue('3');

function setSliderValue(value) {
    popupSliderElem.value = value;
    UpdateSize(value);
}

function UpdateSize(value) {
    let textSizeStr = 'Размер текста: ';
    switch (value) {
        case '1':
            textSizeStr += 'ultra short (50 символов)';
            break;
        case '2':
            textSizeStr += 'short (25%)';
            break;
        case '3':
            textSizeStr += 'medium (50%)';
            break;
        case '4':
            textSizeStr += 'large (75%)';
            break;
        case '5':
            textSizeStr += 'full (100%)';
            break;
    }
    popupCharacterCountElem.innerHTML = textSizeStr;
}
function GetSliderValue() {
    return popupSliderElem.value;
}