function createPhoneBook(array) {
    const phoneObj = array.reduce((acc, curr) => {
      const [name, phone] = curr.split(" ");
      acc[name] = phone;
      return acc;
    }, {});
    Object.entries(phoneObj).forEach(([key, value]) => {
      console.log(`${key} -> ${value}`);
    });
  }
  
  createPhoneBook([
    "Tim 0834212554",
    "Peter 0877547887",
    "Bill 0896543112",
    "Tim 0876566344",
  ]);

  createPhoneBook([
  'George 0552554',
  'Peter 087587',
  'George 0453112',
  'Bill 0845344'
  ]);