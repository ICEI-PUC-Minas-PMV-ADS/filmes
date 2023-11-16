// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function updateAssistidoStatus(id, isChecked) {
    $.ajax({
        url: '/Filmes/UpdateAssistidoStatus',
        type: 'POST',
        data: { id: id, isChecked: isChecked },
        success: function (result) {
            // Handle success if needed
        },
        error: function (error) {
            console.error('Error updating Assistido status:', error);
        }
    })
}



document.addEventListener('DOMContentLoaded', function () {
    const darkModeToggle = document.getElementById('flexSwitchCheckChecked');
    const body = document.body;


    const isDarkModeEnabled = localStorage.getItem('darkMode') === 'enabled';


    if (isDarkModeEnabled) {
        enableDarkMode();
    }


    darkModeToggle.addEventListener('click', function () {
        if (body.classList.contains('dark-mode')) {
            disableDarkMode();
        } else {
            enableDarkMode();
        }
    });


    function enableDarkMode() {
        body.classList.add('dark-mode');

        localStorage.setItem('darkMode', 'enabled');
    }


    function disableDarkMode() {
        body.classList.remove('dark-mode');

        localStorage.removeItem('darkMode');
    }
});

