async function loadRepos() {
   let response = await fetch(
      "https://api.github.com/users/peterdidimitrov/repos"
    );
    let data = await response.json();
    document.querySelector("#res").textContent = JSON.stringify(data);
}