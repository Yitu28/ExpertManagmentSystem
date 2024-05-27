
 $(document).ready(function () {

     $(".Freelaaos").click(function () {
         $("#Freelaaos").show();
         $("#Freelaars").hide();
     });

     $(".Freelaars").click(function () {
         $("#Freelaaos").hide();
         $("#Freelaars").show();
     });

   

   $(".FRbreak").click(function () {
         $("#FRbreakbtn").show();
         $("#FRappealbtn").hide();
     });

     $(".FRappeal").click(function () {
         $("#FRbreakbtn").hide();
         $("#FRappealbtn").show();
     });
 });



$(document).ready(function () {
    $('.SectrorsDepartmentId').attr('disabled', true);
    getworedadepartments();
    
});

function getworedadepartments() {
    $('.SectrorsDepartmentId').empty();
    $.ajax({
        url: '/CCFreeLaaos/Departmentslists',
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('.SectrorsDepartmentId').attr('disabled', false);  
                $('.SectrorsDepartmentId').append('<option value="" > ------- የስራ ክፍል ይምረጡ  --------</option>');
                $.each(response, function (i, data) {
                    $('.SectrorsDepartmentId').append('<option value=' + data.sectrorsDepartmentId + '>' + data.departmentName + '</option>');
                });
            }
            else
            {
                $('.SectrorsDepartmentId').attr('disabled', true);  
                $('.SectrorsDepartmentId').append('<option value="" > ------- የስራ ክፍል ዝርዝር አልተገኘም --------</option>');

            }
            
        }
    });
}

