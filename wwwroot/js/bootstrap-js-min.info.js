
 $(document).ready(function () {
     $("#custom-content-below-home-tab").click(function () {
         $("#Freelaaos").show();
         $("#Freelaars").hide();
        });

     $("#custom-content-below-profile-tab").click(function () {
         $("#Freelaaos").hide();
         $("#Freelaars").show();
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

