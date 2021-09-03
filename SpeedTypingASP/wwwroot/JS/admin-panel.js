var blocks = [];
blocks[0] = 
{
    name: 'Texts',
    button: document.getElementById('admin-panel__texts-edit-button'),
    block: document.getElementById('admin-panel__text-selection'),
    isActive: false,
    defaultDisplay: 'block',
};
blocks[1] = 
{
    name: 'Users',
    button: document.getElementById('admin-panel__users-button'),
    block: document.getElementById('admin-panel__users'),
    isActive: false,
    defaultDisplay: 'flex',
};
for(let i = 0; i < blocks.length; i++)
    SetInactiveBlock(blocks[i]);
SetActiveBlock(blocks[0]);

function adminPanelButtonClicked()
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
    blockToSet.button.classList.add('admin-panel__button-active');

}
function SetInactiveBlock(blockToSet)
{
    blockToSet.isActive = false;
    blockToSet.block.style.display = 'none';
    blockToSet.button.classList.remove('admin-panel__button-active');
}