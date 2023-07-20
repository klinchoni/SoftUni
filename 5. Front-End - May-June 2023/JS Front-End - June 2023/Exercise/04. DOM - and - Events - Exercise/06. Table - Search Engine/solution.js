function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
     const searchQuery = document.querySelector("#searchField").value;
     const cells = Array.from(document.querySelectorAll("tbody td"));
     const activeRows = Array.from(document.querySelectorAll("tbody tr.select"));
   
     activeRows.forEach((row) => {
       row.classList.remove("select");
     });
   
     cells
       .filter((cell) => cell.textContent.includes(searchQuery))
       .forEach((cell) => {
         cell.parentElement.classList.add("select");
       });
   
     //  cells.forEach((cell) => {
     //    if (cell.textContent.includes(searchQuery)) {
     //      cell.parentElement.classList.add("select");
     //    }
     //  });
   }
}

// SECOND WAY:

function solve() {
  document.querySelector('#searchBtn').addEventListener('click', onClick);

  function onClick() {
     clear();
     let rows = document.querySelectorAll('tbody td');
     let input = document.getElementById('searchField');
     let string = input.value;
     
     for (const row of rows) {
        if(row.textContent.includes(string)){
           row.parentElement.classList.add('select');
        } 
     }

     input.value = '';
  }

  function clear(){
     let rows = document.querySelectorAll('tbody td');
     for (const row of rows) {
        row.parentElement.classList.remove('select');
     }
  }
}