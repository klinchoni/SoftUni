function lockedProfile() {
        const buttons = Array.from(document.querySelectorAll("button"));
      
        buttons.forEach((button) => {
          button.addEventListener("click", handleClick);
        });
      
        function handleClick(e) {
          const lockedRadioButton = e.currentTarget.parentElement.querySelector(
            'input[type="radio"]'
          );
      
          if (lockedRadioButton.checked) {
            return;
          }
      
          const isHidden = e.currentTarget.textContent === "Show more";
          const hiddenInfo = e.currentTarget.parentElement.querySelector("div");
      
          hiddenInfo.style.display = isHidden ? "block" : "none";
          e.currentTarget.textContent = isHidden ? "Hide it" : "Show more";
        }
}

// SECOND WAY:

function lockedProfile() {
  const buttons = document.getElementsByTagName('button');
  for (const button of buttons) {
      button.addEventListener('click', toggleInformation)
  }

  function toggleInformation(e) {
      let profile = e.target.parentElement;
      let userInfo = profile.querySelector('div');
      let isUnlock = profile.querySelector("input[value =unlock]").checked;

      if (isUnlock && e.target.textContent === 'Show more') {
          userInfo.style.display = 'block';
          e.target.textContent = 'Hide it';
      } else {
          if(isUnlock) {
              userInfo.style.display = 'none';
              e.target.textContent = 'Show more';
          }
      }
  }
}