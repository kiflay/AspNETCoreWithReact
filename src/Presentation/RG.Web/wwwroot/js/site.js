// Write your JavaScript code.
jQuery(document).ready(function () {
    jQuery("#addButton").click(function () {

        console.log('add new');
        jQuery(".new-form").show();

    });
    jQuery("#cancel-form").click(function (e) {
        e.preventDefault();
        console.log('add new');
        jQuery(".new-form").hide();

    });
});
