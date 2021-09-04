const textarea = document.getElementById('text-edit__textarea');
textarea.addEventListener('keyup', e => {
    let scHeight = e.target.scrollHeight;
    textarea.style.height = `${scHeight}px`;
});