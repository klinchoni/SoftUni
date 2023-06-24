function calcDiffBetweenOddAndEven (arr) {
    let sumOdd = 0;
    let sumEven = 0;

    arr.forEach(function (element) {
        if (element % 2 === 0) {
            sumEven += element;
        } else {
            sumOdd += element;
        }
    });

    console.log(sumEven - sumOdd);
}

calcDiffBetweenOddAndEven([3,5,7,9]);