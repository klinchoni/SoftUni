function createListOfEmployees(input) {
  input.forEach((employee) => {
    console.log(`Name: ${employee} -- Personal Number: ${employee.length}`);
  });
}

// COMPLEX SOLUTION
function createListOfEmployees(arr) {
    let employees = arr.reduce((acc, crr) => {
      acc[crr] = crr.length;
      return acc;
    }, {});
  
    Object.entries(employees).forEach(([employeeName, personalNum]) => {
      console.log(`Name: ${employeeName} -- Personal Number: ${personalNum}`);
    });

   //Object.keys(employees).forEach((key) => {
   //  console.log(`Name: ${key} -- Personal Number: ${employees[key]}`);
   //});
  }
  

  createListOfEmployees([
    'Silas Butler',
    'Adnaan Buckley', 
    'Juan Peterson',
    'Brendan Villarreal'
   ]);

  createListOfEmployees([
    "Samuel Jackson",
    "Will Smith",
    "Bruce Willis",
    "Tom Holland",
  ]);
