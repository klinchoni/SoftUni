function printNthElemFromArr (arr, num) {
    let output = [];

    for(let i = 0; i < arr.length; i++) {
        if(i % num === 0) {
            output.push(arr[i]);
        }
    }

    return output;
}

printNthElemFromArr(['dsa','asd','test','tset'],2);