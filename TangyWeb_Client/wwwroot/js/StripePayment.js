redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51PUWpvLOFmJgErEpKJKdRVRNnRzPR79jzEcGBcf2WiVjTZlGcqEklREFh6zndgkz4Zbmqiigs96Ki6T0S5IW8zBv0074qb9Smc");
    stripe.redirectToCheckout({ sessionId: sessionId });
}