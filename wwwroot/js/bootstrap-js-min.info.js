$(document).ready(function () {
    $('.ZonalSectorsId').attr('disabled', true);
    getworedazones();
    getworedalists();

});


function getworedalists() {
    $('.WoredaSectorsIds').empty();
    $.ajax({
        url: '/CCReports/Woredadatalists',
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('.WoredaSectorsIds').attr('disabled', false);
                $('.WoredaSectorsIds').append('<option value="" > ------- የመጣበት ወረዳ ይምረጡ  --------</option>');
                $.each(response, function (i, data) {
                    $('.WoredaSectorsIds').append('<option value=' + data.woredaSectorsId + '>' + data.woredaSectorsName + '</option>');
                });
            }
            else {
                $('.WoredaSectorsIds').attr('disabled', true);
                $('.WoredaSectorsIds').append('<option value="" > ------- የመጣበት ወረዳ ዝርዝር አልተገኘም --------</option>');

            }

        }
    });
}




function getworedazones() {
    $('.ZonalSectorsId').empty();
    $.ajax({
        url: '/CCReports/Zonedatalists',
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('.ZonalSectorsId').attr('disabled', false);
                $('.ZonalSectorsId').append('<option value="" > ------- የመጣበት ዞን ይምረጡ  --------</option>');
                $.each(response, function (i, data) {
                    $('.ZonalSectorsId').append('<option value=' + data.zonalSectorId + '>' + data.zonalSectorName + '</option>');
                });
            }
            else {
                $('.ZonalSectorsId').attr('disabled', true);
                $('.ZonalSectorsId').append('<option value="" > ------- የመጣበት ዞን ዝርዝር አልተገኘም --------</option>');

            }

        }
    });
}



$(document).ready(function () {
    $('#ZonalSectorsId').change(function () {
        var SectorZoneIds = $(this).val();
        console.log(SectorZoneIds);
        $('#WoredaSectorsId').empty();
        $('#WoredaSectorsId').append('<option value=""> ------- ወረዳ ይምረጡ --------</option>');
        $.ajax({
            url: '/CCReports/Woredalists?SectorZoneIds=' + SectorZoneIds,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#WoredaSectorsId').append('<option value=' + data.woredaSectorsId + '>' + data.woredaSectorsName + '</option>');
                });
            }
        });
    });
});



$(document).ready(function () {














    $("#ReportContents").on('change', function () {

        var ReportContents = $(".ReportContents").val();
        var ReportTypes = $(".ReportTypes").val();

        if (ReportContents == "RegZoneWoreda" && ReportTypes == "PresecutorDecisions") {
            $("#ReportsIndex").show();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "RegZoneWoreda" && ReportTypes == "CourtDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").show();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Regions" && ReportTypes == "PresecutorDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").show();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Regions" && ReportTypes == "CourtDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").show();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Zones" && ReportTypes == "PresecutorDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").show();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Zones" && ReportTypes == "CourtDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").show();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Woredas" && ReportTypes == "PresecutorDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").show();
            $("#WoredaCourtReports").hide();
        }

        else if (ReportContents == "Woredas" && ReportTypes == "CourtDecisions") {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").show();
        }

        else
        {
            $("#ReportsIndex").hide();
            $("#CourtReportsIndex").hide();
            $("#RegReports").hide();
            $("#RegCourtReports").hide();
            $("#ZoneReports").hide();
            $("#ZoneCourtReports").hide();
            $("#WoredaReports").hide();
            $("#WoredaCourtReports").hide();
        }

    });







     $("#ActivityFreelCategory").on('change', function () {

         var FreelCategory = $(".ActivityFreelCategory").val();

         
         if (FreelCategory == 0) {
             $("#AppealOpen").show();
             $("#AppealResponse").hide();
             $("#BreakingOpen").hide();
             $("#BreakingResponse").hide();
             $("#DirectchargeOpen").hide();
             $("#DirectchargeResponse").hide();
         }
         else if (FreelCategory == 1) {
             $("#AppealResponse").show();
             $("#AppealOpen").hide();
             $("#BreakingOpen").hide();
             $("#BreakingResponse").hide();
             $("#DirectchargeOpen").hide();
             $("#DirectchargeResponse").hide();
         }
         else if (FreelCategory == 2) {
             $("#BreakingOpen").show();
             $("#AppealResponse").hide();
             $("#AppealOpen").hide();
             $("#BreakingResponse").hide();
             $("#DirectchargeOpen").hide();
             $("#DirectchargeResponse").hide();
         }
         else if (FreelCategory == 3) {
             $("#BreakingResponse").show();
             $("#AppealResponse").hide();
             $("#AppealOpen").hide();
             $("#BreakingOpen").hide();
             $("#DirectchargeOpen").hide();
             $("#DirectchargeResponse").hide();
         }
         else if (FreelCategory == 4) {
             $("#DirectchargeOpen").show();
             $("#AppealResponse").hide();
             $("#AppealOpen").hide();
             $("#BreakingOpen").hide();
             $("#BreakingResponse").hide();
             $("#DirectchargeResponse").hide();

         }
         else if (FreelCategory == 5) {
             $("#DirectchargeResponse").show();
             $("#AppealResponse").hide();
             $("#AppealOpen").hide();
             $("#BreakingOpen").hide();
             $("#BreakingResponse").hide();
             $("#DirectchargeOpen").hide();
         }
         else {
         }
     });













     $("#AppointmentService").on('change', function () {
         var AppointmentServicess = $(".AppointmentService").val();
         
         if (AppointmentServicess == 'NextAppointment')
         {
             $("#Appointmentclass").show();
             $("#Courtdecisionclass").hide();
         }
         else if (AppointmentServicess == 'CourtDecisions') {
             $("#Appointmentclass").hide();
             $("#Courtdecisionclass").show();
         }
         else{
             $("#Appointmentclass").hide();
             $("#Courtdecisionclass").hide();
         }
     });

     $(".Freelaaos").click(function () {
         $("#Freelaaos").show();
         $("#Freelaars").hide();
     });

     $(".Freelaars").click(function () {
         $("#Freelaaos").hide();
         $("#Freelaars").show();
     });

     $(".customtabsmessagestab").click(function () {
         $("#Freelaaos").show();
         $("#Freelaars").hide();
         $("#custom-content-below-home-tab").show();
         $("#custom-content-below-profile-tab").show();
     });

     $(".customsettingstab").click(function () {
         $("#Freelaaos").hide();
         $("#Freelaars").show();
         $("#custom-content-below-home-tab").show();
         $("#custom-content-below-profile-tab").show();
     });

     $(".customtabsone_messagestab").click(function () {
         $("#Freelaaos").show();
         $("#Freelaars").hide();
         $("#custom-content-below-home-tab").show();
         $("#custom-content-below-profile-tab").show();
     });

     $(".customtabsone_settingstab").click(function () {
         $("#Freelaaos").hide();
         $("#Freelaars").show();
         $("#custom-content-below-home-tab").show();
         $("#custom-content-below-profile-tab").show();
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

