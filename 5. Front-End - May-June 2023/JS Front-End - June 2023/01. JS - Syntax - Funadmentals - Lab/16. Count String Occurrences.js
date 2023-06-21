function countStringOccurrences (text, word) {
    const occurences = text.split(" ").filter(function (element) {
        return element === word;
    }).length;
    console.log(occurences);
}

countStringOccurrences('softuni is great place for learning new programming languages', 'softuni');

// Second way:
//function countStringOccurrences (text, word) {
//    const words = text.split(" ");
//    let occurences = 0;
//
//    for(let i=0; i<words.length; i++) {
//        if (words[i] === word) {
//            occurences++;
//        }
//    }
//    console.log(occurences);
//}
//
//countStringOccurrences('softuni is great place for learning new programming languages', 'softuni');