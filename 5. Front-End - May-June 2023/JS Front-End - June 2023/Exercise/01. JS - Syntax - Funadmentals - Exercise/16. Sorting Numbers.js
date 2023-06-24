function sortingNums (arr) {
    const sortedArray = arr.sort((a, b) => a - b);
    const resultArray = [];
    const length = arr.length;

    for (let i = 0; i < length; i++) {
        if (i % 2 === 0) {
            resultArray.push(sortedArray.shift());
        } else {
            resultArray.push(sortedArray.pop());
        }
    }

    console.log(resultArray)
}

sortingNums([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);

//Judje accepts this solution :

//function sortingNums(array) {
//    let sortedArray = array.sort((a,b)=>a-b);
//    let sortedArrayLength = array.length;
//    
//
//    let newArray = [];
//
//    let loops = 0;
//
//    if (sortedArrayLength % 2 === 0) {
//        loops = sortedArrayLength / 2;
//    } else {
//        loops = sortedArrayLength / 2 - 0.5;
//    }
//
//    for (let index = 0; index < loops; index++) {   
//        let first = sortedArray.shift();
//        let second = sortedArray.pop();
//
//        newArray.push(first);
//        newArray.push(second);
//    }
//    if (sortedArrayLength % 2 !== 0) {
//        let lastElement = sortedArray.pop();
//
//        newArray.push(lastElement);
//    }
//    return newArray;
//}

// Second way:

//function sortingNums(arr) {
//    arr.sort((a, b) => a - b);
//  
//    const result = [];
//    let left = 0;
//    let right = arr.length - 1;
//  
//    while (left <= right) {
//      result.push(arr[left]);
//  
//      if (left === right) {
//        break;
//      }
//      result.push(arr[right]);
//      left++;
//      right--;
//    }
//    return result;
//  }