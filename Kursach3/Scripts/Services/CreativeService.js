app.service("creativeService", function ($http) {

    this.getPopularCreatives = function (scope) {
        scope.creative = {
            Id: null,
            Name: null,
            Rank: null,
            Count: null,
            CreateData: null,
            RedactData: null,
            UserId: null
        };
        scope.creatives = [];
        $http.get("/Creative/GetPopularCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };

    this.getNewCreatives = function (scope) {
        scope.creatives = [];
        $http.get("/Creative/GetNewCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };



});