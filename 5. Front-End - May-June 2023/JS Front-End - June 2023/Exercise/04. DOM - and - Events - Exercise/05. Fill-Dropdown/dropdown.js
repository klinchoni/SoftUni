function addItem() {
    const textInput = document.querySelector("#newItemText");
    const valueInput = document.querySelector("#newItemValue");
  
    const option = createOption(textInput.value, valueInput.value);
  
    const select = document.querySelector("#menu");
    select.appendChild(option);
    clearInputFields();
  
    function createOption(text, value) {
      const option = document.createElement("option");
      option.textContent = text;
      option.value = value;
  
      return option;
    }
  
    function clearInputFields() {
      const inputs = Array.from(document.querySelectorAll("input"));
      inputs.forEach((input) => (input.value = ""));
    }
}

// SECOND WAY:

function addItem() {
  let text = document.getElementById('newItemText');
  let itemValue = document.getElementById('newItemValue');
  let select = document.getElementById('menu');

  let option = document.createElement('option');
  option.textContent = text.value;
  option.value = itemValue.value;
  select.appendChild(option);

  text.value = '';
  itemValue.value = '';
}