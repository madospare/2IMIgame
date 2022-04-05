SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

-- Table structure for table `sc_users`

CREATE TABLE `sc_users` 
(

    `user_id` int(11) NOT NULL,
    `username` varchar(20) CHARACTER SET utf8 NOT NULL,
    `email` varchar(254) CHARACTER SET utf8 NOT NULL,
    `password` char(60) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
    `registration_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP

) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Indexes for table `sc_users`

ALTER TABLE `sc_users`
    ADD PRIMARY KEY (`user_id`),
    ADD UNIQUE KEY `username` (`username`),
    ADD UNIQUE KEY `email` (`email`);


-- AUTO_INCREMENT for table `sc_users`

ALTER TABLE `sc_users`
    MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
COMMIT;