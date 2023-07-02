// Judge 100/100:

function addAndSubtract(firstNum,secondNum, thirdNum) {
     const sum = (a, b) => a + b;
     const subtract = (c, d) => c - d;
     return subtract(sum(firstNum, secondNum), thirdNum);
}

// Second way:

//const addAndSubtract = (firstNum,secondNum, thirdNum) => {
//    const sum =(a, b) => a + b;
//    const subtract =(c, d) => c - d;
//
//    return subtract(sum(firstNum, secondNum), thirdNum);
//}

console.log(addAndSubtract(1, 17, 30));