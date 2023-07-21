async function loadRepos() {
	const username = document.querySelector("#username").value;
	const list = document.querySelector("#repos");
  
	try {
	  const response = await fetch(
		`https://api.github.com/users/${username}/repos`
	  );
	  if (response.ok === false) {
		throw new Error(`${response.status} ${response.statusText}`);
	  }
	  const data = await response.json();
  
	  list.innerHTML = "";
	  data.forEach((repo) => {
		list.innerHTML += `<li>
			  <a href="${repo.html_url}" target="_blank">${repo.full_name}</a>
			</li>`;
	  });
	} catch (err) {
	  list.innerHTML = `${err.message}`;
	}
}