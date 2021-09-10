var elems = document.getElementsByClassName('text-content');
for (var i = 0; i < elems.length; i++) {
    ValidateTextContent(elems[i]);
}

function ValidateTextContent(elem) {
    var text = elem.innerHTML;

    if (text.length > 100) {
        text = text.substring(0, 100);
        elem.innerHTML = `${text}...`;
    }
}