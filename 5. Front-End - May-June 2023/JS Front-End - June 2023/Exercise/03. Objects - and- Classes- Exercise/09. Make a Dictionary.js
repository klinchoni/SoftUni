function solve(input) {
    const dictionary = input.reduce((acc, curr) => {
      const term = JSON.parse(curr);
      acc = { ...acc, ...term };
      return acc;
    }, {});
  
    // ALTERNATIVE SOLUTION
    //   let dictionary = {};
  
    //   input.forEach((jsonString) => {
    //     const term = JSON.parse(jsonString);
    //     dictionary = Object.assign(dictionary, term);
    //   });
  
    const sortedDictionaryTerms = Object.keys(dictionary).sort();
  
    sortedDictionaryTerms.forEach((term) =>
      console.log(`Term: ${term} => Definition: ${dictionary[term]}`)
    );
  }

  // SECOND WAY:
 //function solve(input) {
 //  const dictionary = input
 //  // ['', '', '', '']
 //  .map((jsonString) => JSON.parse(jsonString))
 //  // map -> [{}, {}, {}, {}]
 //  .reduce((acc, curr) => {
 //    return {
 //      ...acc,
 //      ...curr,
 //    };
 //  }, {});
 //
 //  // reduce -> {coffee: '...'}
 //
 //  console.log(JSON.stringify(dictionary, null, 2));
 //}
  
  solve([
    '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}',
  ]);