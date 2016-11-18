app.controller("userDataController", function ($scope, userPageService) {

    userPageService.getUser($scope);

});

app.controller("userCreativesController", function ($scope, userPageService) {

    userPageService.getUserCreatives($scope);

});