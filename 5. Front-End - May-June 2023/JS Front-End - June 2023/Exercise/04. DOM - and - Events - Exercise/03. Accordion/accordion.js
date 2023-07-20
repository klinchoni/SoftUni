function toggle() {
        const content = document.querySelector("#extra");
        const button = document.querySelector("span.button");
      
        content.style.display = content.style.display === "block" ? "none" : "block";
        button.textContent = button.textContent === "More" ? "Less" : "More";
}

// SECOND WAY:
function toggle() {
        let button = document.getElementsByClassName('button')[0];
        let info = document.getElementById('extra');
    
        if(info.style.display === 'none') {
            info.style.display = 'block';
            button.textContent = 'Less';
        } else {
            info.style.display = 'none';
            button.textContent = 'More';
        }
    }