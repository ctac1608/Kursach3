app.controller('searchController', function ($scope, $http, $window, $location) {

    $scope.search = function () {
        $window.location.href = "http://localhost:52038/Home/SearchPage/" + this.searchRow;
    };

});