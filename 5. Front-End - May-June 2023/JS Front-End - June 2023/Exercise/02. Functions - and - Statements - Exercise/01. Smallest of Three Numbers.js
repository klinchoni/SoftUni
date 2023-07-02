// Judge 100/100:

function smallestOfThreeNums(firstNum, secondNum, thirdNum){
    let min = Math.min(firstNum, secondNum, thirdNum);
   return min;
}

// Second way:

//const smallestOfThreeNums = (firstNum, secondNum, thirdNum) => Math.min(firstNum, secondNum, thirdNum);

console.log(smallestOfThreeNums(2,5,3));