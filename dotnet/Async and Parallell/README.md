# Async & Parallell example

Simple example for myself to illustrate how basic Async & Parallell works.

Code output:
```
Starting Async example
---------------------------------------
22:45:56 worker 1: Starting run with a 2 second sleep
22:45:56 worker 2: Starting run with a 2 second sleep
22:45:58 worker 1: Sleeping another 2 seconds
22:45:58 worker 2: Sleeping another 2 seconds
22:45:59 worker 3: Starting run with a 2 second sleep
22:46:00 worker 1: Done
22:46:00 worker 2: Done
22:46:01 worker 3: Sleeping another 2 seconds
22:46:03 worker 3: Done
---------------------------------------
Async example done
Starting Parallell Example
---------------------------------------
22:46:03: Starting '1343' seconds sleep
22:46:03: Starting '703' seconds sleep
22:46:03: Starting '196' seconds sleep
22:46:03: Starting '1800' seconds sleep
22:46:03: Starting '621' seconds sleep
22:46:03: Done sleeping '196'
22:46:03: Done sleeping '621'
22:46:03: Done sleeping '703'
22:46:04: Done sleeping '1343'
22:46:04: Done sleeping '1800'
---------------------------------------
Done, Press any key to exit ...
```