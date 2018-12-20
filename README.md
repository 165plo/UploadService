# UploadService
The service will receive files via a HTTP POST using chunked transfer encoding and stream them to the file system. Once 
the file has been written to disk the service will notify other services, via webhooks, that a new file needs to be processed.

Currently I am unable to get the body of the file being sent to the server. I am able to get into the controller method but am unable to get the file from the Request.Body. 
