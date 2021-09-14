var blocks = [];
blocks[0] = 
{
    name: 'Profile',
    button: document.getElementById('personal-account__profile-button'),
    block: document.getElementById('personal-account__profile-blcok'),
    isActive: false,
    defaultDisplay: 'block',
};
blocks[1] = 
{
    name: 'Users',
    button: document.getElementById('personal-account__progress-button'),
    block: document.getElementById('personal-account__progress-blcok'),
    isActive: false,
    defaultDisplay: 'block',
};
blocks[2] = 
{
    name: 'Users',
    button: document.getElementById('personal-account__personalization-button'),
    block: document.getElementById('personal-account__personalization-blcok'),
    isActive: false,
    defaultDisplay: 'block',
};
for(let i = 0; i < blocks.length; i++)
    SetInactiveBlock(blocks[i]);
SetActiveBlock(blocks[0]);

function personalAccButtonClicked()
{
    const sender = event.target;
    for(let i = 0; i < blocks.length; i++)
        if(blocks[i].button === sender)
        {
            var blockToSet = blocks[i];
            break;
        }
    for(let i = 0; i < blocks.length; i++)
        SetInactiveBlock(blocks[i]);
    SetActiveBlock(blockToSet);
}

function SetActiveBlock(blockToSet)
{
    blockToSet.isActive = true;
    blockToSet.block.style.display = blockToSet.defaultDisplay;
    blockToSet.button.classList.add('personal-account__header-element-active');

}
function SetInactiveBlock(blockToSet)
{
    blockToSet.isActive = false;
    blockToSet.block.style.display = 'none';
    blockToSet.button.classList.remove('personal-account__header-element-active');
}

function ClearTextStatistics(textName) {
    const form = document.getElementById('personal-account__ClearTextStatistics');

    form.setAttribute('action', `/Account/RemoveTextStatistics?textTitle=${textName}`);

    form.submit();
}