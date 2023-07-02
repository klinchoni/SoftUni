function calculateAverage(num) {
    return (
      num
        .split("")
        .map(Number)
        .reduce((total, curr) => total + curr, 0) / num.length
    );
  }
  
  function solve(num) {
    num = num.toString();
    let average = calculateAverage(num);
  
    while (average < 5) {
      num += "9";
      average = calculateAverage(num);
    }
  
    return num;
  }
  
  console.log(solve(101));
  console.log(solve(5835));

// Second way (100/100 in Judge):

//  function numModification(numbers) {
//    numbers = numbers.toString();
//
//    function average(numbers) {
//        let sum = 0
//        for(let number of numbers) {
//            sum += parseInt(number)
//        }
//        return sum / numbers.length
//    }
//
//    while(average(numbers) < 5) {
//        numbers += '9';
//    }
//    console.log(numbers)
//}
//
//numModification(101);