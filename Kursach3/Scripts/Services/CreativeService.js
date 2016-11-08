app.service("creativeService", function ($http) {

    this.getPopularCreatives = function (scope) {
        $http.get("/Creative/GetPopularCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };

    this.getNewCreatives = function (scope) {
        $http.get("/Creative/GetNewCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };

    //this.createCreative = function (creative) {
    //    var creative = {
    //        Name: creative.Name,
    //        Tags: creative.Tags,
    //        Rank: 0,
    //        Count: 0
    //    }

    //    $.post("/Creative/Create/", creative, function (response) {
    //        creative.Id = response;
    //        notes.push(note);
    //        callback();
    //    });
    //};



});