NotificationFactory emailFactory = new EmailFactory();
INotification email = emailFactory.CreateNotification();
email.Send("Welcome via Email!");

NotificationFactory smsFactory = new SmsFactory();
INotification sms = smsFactory.CreateNotification();
sms.Send("OTP Sent via SMS!");

NotificationFactory pushFactory = new PushFactory();
INotification push = pushFactory.CreateNotification();
push.Send("New Offer Available!");