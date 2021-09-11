const htmlEditTemplate = '<div class="text-edit__character-edit-block">' +
    '<p class="text-edit__character-edit" contenteditable="true"></p>' +
    '<p class="text-edit__character-edit-arrow">arrow_forward</p>' +
    '<p class="text-edit__character-edit" contenteditable="true"></p>' +
    '</div>';

const textEditTextareaForReplceChars = document.getElementById('text-edit__textarea');
const wrapper = document.getElementById('text-edit__character-edit-wrapper');
const addTextToChangeBtn = document.getElementById('add-text-to-change-btn');
const changeTextBtn = document.getElementById('change-text-btn');
var countOfReplacements = 0;

addTextToChangeBtn.onclick = AddCharactersToReplace;
changeTextBtn.onclick = ChangeText;

function AddCharactersToReplace() {
    var currentReplace = `<div class="text-edit__character-edit-block" id="text-edit__character-edit-block-${countOfReplacements}">` +
        `<p class="text-edit__character-edit" id="text-edit__character-edit-from-${countOfReplacements}" contenteditable="true"></p>` +
        '<p class="text-edit__character-edit-arrow">arrow_forward</p>' +
        `<p class="text-edit__character-edit" id="text-edit__character-edit-to-${countOfReplacements}" contenteditable="true"></p></div>`;
    countOfReplacements++;
    wrapper.innerHTML += currentReplace;
}
function ChangeText() {
    let textareaContent = textEditTextareaForReplceChars.value;
    for (let i = 0; i < countOfReplacements; i++) {
        let from = document.getElementById(`text-edit__character-edit-from-${i}`).innerHTML;
        let to = document.getElementById(`text-edit__character-edit-to-${i}`).innerHTML;

        var regExp = new RegExp(from, 'g');

        textareaContent = textareaContent.replaceAll(regExp, to);
    }
    textEditTextareaForReplceChars.value = textareaContent;
}