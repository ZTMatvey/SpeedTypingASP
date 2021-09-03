function Get123()
{
    return 1234;
}

$(document).ready(function(){
    console.log(Get123());

    var inputField = document.getElementById('text-input-field');
    var correctStringTextbox = document.getElementById('actual-correct-string-textbox');

    var correctString = 'Lorem ipsum, dolor sit amet consectetur adipisicing elit. Rerum neque totam deserunt, voluptate libero ipsum soluta aliquam sunt quasi minima fugit, perferendis et suscipit dolorem quod dignissimos. Labore, rem voluptate?';

    correctStringTextbox.innerHTML = correctString;

    var hasError = false;
    
    function validateInputField(){      
        let substringedCorrectStr = correctString.substring(0, inputField.value.length);
        let value = inputField.value;

        if(substringedCorrectStr !== value)
        {
            if(hasError)
                return;
            var lastChar = value[value.length - 1];
            if(lastChar == ' ')
            {
                var substringedValue = value.substring(0, value.length - 1);
                if(substringedValue == correctString)
                {
                    inputField.value = '';
                    return;
                }
            }
            inputField.style.borderColor = 'red';
            inputField.style.backgroundColor = 'rgba(255, 0, 0, .4)';
            hasError = true;
        }
        else if(hasError)
        {
            console.log('hello from else block');
            inputField.style.borderColor = '#9BA1F2';
            inputField.style.backgroundColor = 'transparent';
            hasError = false;
        }
    }

    $('#text-input-field').on('keyup',function(e){
        if(e.keyCode == 13)
            inputField.value += ' ';
        validateInputField();
    });
    $('#text-input-field').on('input',function(e){
        validateInputField();
    });
})