"use strict";

function checkIfAllDigitsAreSame(number) {
    const digits = number.toString().split("").map(Number);
    const isConsistent = new Set(digits).size === 1;
    const sum = digits.reduce((total, number) => total + number, 0);

    console.log(isConsistent);
    console.log(sum);
}


// Second way:
//
//function checkIfAllDigitsAreSame (number) {
//    const digits = Array.from(String(number),Number);
//    const isConsistent = new Set(digits).size === 1;
//    const sum = digits.reduce(function (total,number) {
//        return total + number;
//    }, 0);
//
//    console.log(isConsistent);
//    console.log(sum);
//}

// Third way:
//
//function checkIfAllDigitsAreSame (number) {
//    const digitsString = number.toString();
//    let isConsistent = true;
//    let sum = Number(digitsString[0]);
//
//    for (let i = 1; i < digitsString.length; i++) {
//        sum += Number(digitsString[i]);
//        if (digitsString[i]!== digitsString[i - 1]) {
//            isConsistent = false;
//        }
//    }
//
//    console.log(isConsistent);
//    console.log(sum);
//}

checkIfAllDigitsAreSame(2222222);