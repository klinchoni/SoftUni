function sumDigits (num) {
    const digitsString = num.toString();
    let sum = 0;

    for (let i = 0; i < digitsString.length; i++) {
        sum += Number(digitsString[i]);
    }

    console.log(sum);
}

// Second way: 

//function sumDigits (number) {
//    let sum = 0;
//    let num = number;
//
//    while (num / 10 > 0) {
//        sum += num % 10;
//        num = Math.floor(num/10);
//    }
//
//    console.log(sum);
//}

sumDigits(543);