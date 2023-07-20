function subtract() {
 const inputs = Array.from(document.querySelectorAll("input"));

  function handler() {
    const firstNumber = Number(document.querySelector("#firstNumber").value);
    const secondNumber = Number(document.querySelector("#secondNumber").value);

    console.log(firstNumber, secondNumber);

    const sum = firstNumber - secondNumber;

    const result = document.querySelector("#result");
    result.textContent = sum;
  }

  inputs.forEach((input) => {
    input.removeAttribute("disabled");
    input.addEventListener("keyup", handler);
  });
}

// JUDGE 100/100

function subtract() {
  let firstNumber = document.getElementById('firstNumber').value;
  let secondNumber = document.getElementById('secondNumber').value;
  let result = document.getElementById('result');
  result.textContent = Number(firstNumber) - Number(secondNumber);
}
