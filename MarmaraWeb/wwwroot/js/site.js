function dmOnClick() {
    const button = document.querySelector('.dark-mode-button');
    const nav = document.querySelector('nav');
    const header = document.querySelector('header');
    const body = document.querySelector('body');

    if (button.classList.contains('bg-light')) {
        button.classList.remove('bg-light', 'btn-ligt');
        button.classList.add('bg-dark', 'btn-dark');
        nav.classList.add('bg-light', 'navbar-ligt');
        nav.classList.remove('bg-dark', 'navbar-dark');
        header.classList.add('bg-light', 'navbar-ligt');
        header.classList.remove('bg-dark', 'navbar-dark');
        body.style.backgroundColor = "#f8f9fa";
    }
    else {
        button.classList.add('bg-light', 'btn-ligt');
        button.classList.remove('bg-dark', 'btn-dark');
        nav.classList.remove('bg-light', 'navbar-ligt');
        nav.classList.add('bg-dark', 'navbar-dark');
        header.classList.remove('bg-light', 'navbar-ligt');
        header.classList.add('bg-dark', 'navbar-dark');
        body.style.backgroundColor = "#343a40";
    }
}
const button = document.querySelector('.dark-mode-button');
button.addEventListener('click', dmOnClick);
