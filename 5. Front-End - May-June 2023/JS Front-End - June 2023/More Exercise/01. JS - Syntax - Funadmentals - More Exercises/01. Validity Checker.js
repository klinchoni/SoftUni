"use strict";

function isDistanceValid (x1, y1, x2, y2) {
    function distance(x1, y1, x2, y2) {
        return Math.sqrt((x2-x1) ** 2 + (y2 - y1) ** 2);
    }

    const firstDistance = distance(x1, y1, 0, 0);
    const secondDistance = distance(x2, y2, 0, 0);
    const thirdDistance = distance(x1, y1, x2, y2);

    if (Number.isInteger(firstDistance)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(secondDistance)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(thirdDistance)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}


isDistanceValid(3, 0, 0, 4);

//function calculateDistance (x1, y1, x2, y2) {
//    return Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);
//}
//
//function isDistanceValid (x1, y1, x2, y2) {
//    const distance = calculateDistance(x1, y1, 0, 0);
//    const isValid = Number.isInteger(distance);
//    const status = isValid ? "valid" : "invalid";
//
//    console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${status}.`);
//}
//
//function solve (x1, y1, x2, y2) {
//    isDistanceValid(x1, y1, 0, 0);
//    isDistanceValid(x2, y2, 0, 0);
//    isDistanceValid(x1, y1, x2, y2);
//}
//
//solve(3, 0, 0, 4);