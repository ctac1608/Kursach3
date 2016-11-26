app.service("userPageService", function ($http) {

    this.getUser = function (scope) {
        $http.get("/UserPage/GetUser/").then(function (response) {
            scope.user = response.data;
        });
    };

    this.getUserCreatives = function (scope) {
        scope.creatives = [];
        scope.creative = {
            Id: null,
            Name: null,
            Rank: null,
            Count: null,
            CreateData: null,
            RedactData: null,
            UserId: null
        };

        $http.get("/UserPage/GetUserCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };


});