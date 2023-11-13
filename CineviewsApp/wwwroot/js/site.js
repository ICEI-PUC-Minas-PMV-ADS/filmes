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