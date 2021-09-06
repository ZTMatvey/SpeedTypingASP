const textEditTextarea = document.getElementById('text-edit__textarea');
SetCorrectSizeOfTextArea();

function SetCorrectSizeOfTextArea() {
    let scHeight = textEditTextarea.scrollHeight;
    textEditTextarea.style.height = `${scHeight}px`;
}
textEditTextarea.addEventListener('input', e => {
    SetCorrectSizeOfTextArea();
});