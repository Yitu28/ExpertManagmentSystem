
    $(document).ready(function () {
        $('.SectrorsDepartmentId').attr('disabled', true);
    getworedadepartments();

});

    function getworedadepartments() {
        $('.SectrorsDepartmentId').empty();
    $.ajax({
        url: '/Cr_JudicalAppealOpening/Departmentslists',
    success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
        $('.SectrorsDepartmentId').attr('disabled', false);
    $('.SectrorsDepartmentId').append('<option value="" > ------- የስራ ክፍል ይምረጡ  --------</option>');
    $.each(response, function (i, data) {
        $('.SectrorsDepartmentId').append('<option value=' + data.sectrorsDepartmentId + '>' + data.departmentName + '</option>');
                });
            }
    else {
        $('.SectrorsDepartmentId').attr('disabled', true);
    $('.SectrorsDepartmentId').append('<option value="" > ------- የስራ ክፍል ዝርዝር አልተገኘም --------</option>');

            }

        }
    });
}

//To get Crim Type with dropdown

$(document).ready(function () {
    $('.Cr_Crime_TypeId').attr('disabled', true);
    GetCrimeType();

});

function GetCrimeType() {
    $('.Cr_Crime_TypeId').empty();
    $.ajax({
        url: '/Cr_JudicalAppealOpening/CrimeTypeList',
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('.Cr_Crime_TypeId').attr('disabled', false);
                $('.Cr_Crime_TypeId').append('<option value="" > ------- የወንጀል አይነት  --------</option>');
                $.each(response, function (i, data) {
                    $('.Cr_Crime_TypeId').append('<option value=' + data.cr_Crime_TypeId + '>' + data.crimeTypeName + '</option>');
                });
            }
            else {
                $('.Cr_Crime_TypeId').attr('disabled', true);
                $('.Cr_Crime_TypeId').append('<option value="" > ------- የወንጀል አይነት ዝርዝር አልተገኘም --------</option>');

            }

        }
    });
}

