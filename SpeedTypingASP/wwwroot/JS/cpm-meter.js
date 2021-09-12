var cpmTextElem = document.getElementById('text-write__cpm-text');
var correctInLastPartOfTime = 0;
var partOfTimeCorrects = [];
var cpmInterval;
var currentIndex = 0;
const countOfMeterings = 2 * 8 - 1;

function StartCpmTimer() {
    cpmInterval = setInterval(() => {
        console.log(correctInLastPartOfTime);
        partOfTimeCorrects[currentIndex < countOfMeterings ? currentIndex++ : UpdateIndexAndGetIt()] = correctInLastPartOfTime;
        correctInLastPartOfTime = 0;
        cpmTextElem.innerHTML = `${partOfTimeCorrects.reduce((a, b) => a + b, 0) * 30} cpm`;
    }, 125);
}
function StopCpmTimer() {
    clearInterval(cpmInterval);
}

function UpdateIndexAndGetIt() {
    currentIndex = 0;
    return currentIndex;
}