app.controller('searchController', function ($scope, $http) {

    $scope.searchRow = null;

    $scope.search = function () {
        $http.post("/Home/SearchResult/", $scope.searchRow).then(function () {
        });
    };

});