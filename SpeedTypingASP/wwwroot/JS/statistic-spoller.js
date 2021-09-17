$('.personal-account__text-name')
    .toggleClass('personal-account__text-name-disactive')
    .parent().next().slideToggle(300);

$('.personal-account__text-name').click(function (e) {
    $(this)
        .toggleClass('personal-account__text-name-active')
        .toggleClass('personal-account__text-name-disactive').parent().next().slideToggle(300);
});