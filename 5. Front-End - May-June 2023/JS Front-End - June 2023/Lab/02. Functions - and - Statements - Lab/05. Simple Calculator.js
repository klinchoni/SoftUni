const calculator = {
    multiply: (x, y) => x * y,
    divide: (x, y) => x / y,
    add: (x, y) => x + y,
    subtract: (x, y) => x - y,
};

const calculate = (num1, num2, operator) =>
    calculator[operator] ? calculator[operator](num1, num2) : 0;

//function calculate (num1, num2, operator) {
//    return calculator[operator](num1, num2);
//}

const result = calculate(20, 4, "subtract");

console.log(result);
// Second way:

//const multiply = (x, y) => x * y;
//const divide = (x, y) => x / y;
//const add = (x, y) => x + y;
//const subtract = (x, y) => x - y;
//
//function calculate (num1, num2, operator) {
//    if (operator === "multiply") {
//        return multiply (num1, num2);
//    }
//
//    if (operator === "divide") {
//        return divide (num1, num2);
//    }
//
//    if (operator === "add") {
//        return add (num1, num2);
//    }
//
//    if (operator === "subtract") {
//        return subtract (num1, num2);
//    }
//}
//
//const result = calculate(4, 4, "multiply");
//
//console.log(result);

// Third way:

//function calculator(numOne, numTwo, operator) {
//    const multiply = (a,b) => a*b;
//    const divide = (a,b) => a/b;
//    const sum = (a,b) => a+b;
//    const subtract = (a,b) => a-b;
//
//    switch(operator){
//        case 'multiply':
//            return multiply(numOne, numTwo);
//        
//        case 'divide':
//            return divide(numOne, numTwo);
//        
//        case 'add':
//            return sum(numOne, numTwo);
//        
//        case 'subtract':
//            return subtract(numOne, numTwo);
//        
//    }
//}
