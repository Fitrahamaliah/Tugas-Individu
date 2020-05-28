<?php
    $name = $_POST['name'];
    $visitor_email = $_POST['email'];
    $message = $_POST['message'];

    $email_from = 'fitrah.18007@mhs.unesa.ac.id';

    $email_subject = "New Form Submission";

    $email_body = "User Name : $name.\n".
                    "User E-Mail : $visitor_email.\n".
                        "User Message : $message.\n";

    $to = "fitrahamaliah212@gmail.com";

    $headers = "From : $email_from\r\n";

    $headers .= "Reply-To : $visitor_email \r\n";

    mail($to,$email_subject,$email_body,$headers);

    header("Location: index.html");


?>