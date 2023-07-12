function calc() {
    const num1 = document.getElementById("num1");
    const num2 = document.getElementById("num2");

    const calc = Number(num1.value) + Number(num2.value);

    document.getElementById("sum").value = calc;
}
