let tsPopupElem = document.getElementById('text-selection__popup');
let blurSreenElem = document.getElementById('blur-screen');
let popupTextTitleElem = document.getElementById('text-selection__popup-text-title');

ClosePopUp(true);

function OpenPopUp(textName) {
    if (tsPopupElem.classList.contains('center-disactive'))
        tsPopupElem.classList.remove('center-disactive');
    tsPopupElem.classList.add('center-active');

    if (blurSreenElem.classList.contains('blur-screen-disactive'))
        blurSreenElem.classList.remove('blur-screen-disactive');
    blurSreenElem.classList.add('blur-screen-active');

    popupTextTitleElem.innerHTML = textName;
}
function ClosePopUp(isOnLoad) {
    if (!isOnLoad) {
        blurSreenElem.classList.add('blur-screen-disactive');
        tsPopupElem.classList.add('center-disactive');
    }
    if (tsPopupElem.classList.contains('center-active'))
        tsPopupElem.classList.remove('center-active');
    if (blurSreenElem.classList.contains('blur-screen-active'))
        blurSreenElem.classList.remove('blur-screen-active');
}
function SelectText() {
    const form = document.getElementById('text-selection__form');
    const textTitle = popupTextTitleElem.innerHTML;
    const actionValue = `/Home/TextWrite?textTitle=${textTitle}&textSize=${GetSliderValue()}`;
    form.setAttribute('action', actionValue);

    form.submit();
}