app.controller("userCreativesController", function ($scope, userPageService) {

    userPageService.getUserCreatives($scope);

});