const timerTextElem = document.getElementById("text-write__timer-text");
let timePassed = 0;
var seconds = 0;
var minutes = 0;
var miliSeconds = 0;
var strMiliSeconds;
var strSeconds;
var interval;


function GetTimeFromDivTenMilSeconds(divTenMiliseconds) {
    let _seconds = Math.floor(divTenMiliseconds / 100);
    let _minutes = Math.floor(seconds / 60);
    _seconds %= 100;
    divTenMiliseconds %= 100;
    return `${_minutes}:${_seconds}.${divTenMiliseconds}`;
}
function StartTimer() {

    strMiliSeconds = miliSeconds < 10 ? `0${miliSeconds}` : miliSeconds;
    strSeconds = seconds < 10 ? `0${seconds}` : seconds;
    timerTextElem.innerHTML = `${minutes}:${strSeconds}.${strMiliSeconds}`;

    interval = setInterval(() => {
        timePassed++;
        seconds = Math.trunc(timePassed / 100);
        if (seconds === 60) {
            minutes++;
            seconds = 0;
            timePassed = 0;
        }
        miliSeconds = timePassed % 100;
        strMiliSeconds = miliSeconds < 10 ? `0${miliSeconds}` : miliSeconds;
        strSeconds = seconds < 10 ? `0${seconds}` : seconds;
        timerTextElem.innerHTML = `${minutes}:${strSeconds}.${strMiliSeconds}`;
    }, 10);
}
function GetTime() {
    strMiliSeconds = miliSeconds < 10 ? `0${miliSeconds}` : miliSeconds;
    strSeconds = seconds < 10 ? `0${seconds}` : seconds;
    return `${minutes}:${strSeconds}.${strMiliSeconds}`;
}
function GetNumTime() {
    return (minutes * 60 + seconds) * 100 + miliSeconds;
}
function StopTimer() {
    clearInterval(interval);
}
function MakeTimerGreen() {
    timerTextElem.style.color = 'green';
    timerTextElem.style.borderColor = 'green';
    timerTextElem.style.background = 'rgba(0, 255, 0, .4)';
}