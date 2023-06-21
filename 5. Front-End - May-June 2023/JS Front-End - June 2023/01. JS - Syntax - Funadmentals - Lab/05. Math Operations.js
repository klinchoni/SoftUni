function mathOperations (num1, num2, operator) {
    switch (operator) {
        case '+': console.log(num1 + num2);
        break;
        case '-': console.log(num1 - num2);
        break;
        case '/': console.log(num1 / num2);
        break;
        case '*': console.log(num1 * num2);
        break;
        case '%': console.log(num1 % num2);
        break;
        case '**': console.log(num1 ** num2);
        break;
    }
}

mathOperations(3, 5.5, '*');

// Second way 

//function mathOperations (num1, num2, operator) {
//    let result;
//    switch (operator) {
//        case '+': result = num1 + num2;
//        break;
//        case '-': result = num1 - num2;
//        break;
//        case '/': result = num1 / num2;
//        break;
//        case '*': result = num1 * num2;
//        break;
//        case '%': result = num1 % num2;
//        break;
//        case '**': result = num1 ** num2;
//        break;
//    }
//    console.log(result);
//}

