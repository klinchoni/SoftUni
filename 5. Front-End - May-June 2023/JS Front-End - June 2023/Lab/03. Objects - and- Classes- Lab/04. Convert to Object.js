function convertToObj(jsonStr) {
    let person = JSON.parse(jsonStr);

    for (const key in person) {
        console.log(`${key}: ${person[key]}`);
      }
}

convertToObj('{"name": "George", "age": 40, "town": "Sofia"}');