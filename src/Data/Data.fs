﻿module Data

open ilf.pgn
open ilf.pgn.Data


let loadAllMoves fileName =
    // let reader = PgnReader()
    // let gameDb = reader.ReadFromFile fileName
    // let game = gameDb.Games.
    // game.MoveText
    let invalid =  @"1. Nf3 Nf6 2. c4 e6 3. d4 b6 4. g3 Ba6 5. b3 b5 6. BXa2 Qc3 "
    //let valid =  @"1. Nf3 Nf6 2. c4 e6 3. d4 b6 4. g3 Ba6 5. b3 b5 "
    //let valid = "1. Nf3 Nf6 2. c4 c5 3. g3 g6 4. Bg2 Bg7 "
    //let valid = "1. d4 Nf6 2. c4 e6 3. Nf3 b6 4. g3 Ba6 "
    let valid = "1. Nf3 Nf6 2. c4 c6 3. d4 d5 4. e3 Bg4 "
    valid
    //6. cxb5 Bxb5 7. Bg2 d5 8. Nc3 Ba6 9. O-O Nbd7 10. Ne5 Bd6 11. Bf4 O-O 12. Rc1 Bxe5 13. dxe5 Ng4 14. Nxd5 exd5 15. Qxd5 Nb6 16. Qa5 Bxe2 17. Rfe1 Bd3 18. Red1 Qd4 19. Rd2 Rad8 20. h3 Nxf2 21. Rxf2 Be4 22. Qxa7 Bxg2 23. Kxg2 Qe4+ 24. Kh2 Nd5 25. Rc4 Qb1 26. Rd4 h5 27. Bg5 Rd7 28. Qc5 Qe1 29. Rg2 Qxe5 30. Bf4 Qe6 31. Rgd2 Nxf4 32. gxf4 Rxd4 33. Qxd4 Re8 34. b4 Qf5 35. Rf2 h4 36. a4 Re4 37. Qd8+ Kh7 38. Qxh4+ Kg8 39. Qg5 Qd7 40. a5 Rxb4 41. Rg2 Qd4 42. a6 Ra4 43. Qg4 Qf6 44. Qg5 Rxa6 45. Qxf6 Rxf6 46. Rc2 c6 47. Kg3 Kf8 48. Kf3 Ke7 49. Ke4 g6 50. h4 Kd6 51. Ra2 Rf5 52. Ra7 c5 53. Ra8 Rh5 54. Ra6+ Ke7 55. Ra7+ Kf6 56. Ra6+ Kg7 57. Rc6 Rf5 58. Rc8 Rh5 59. Rc6 Kf8 60. Rc7 Ke8 61. Kf3 Rf5 62. Ke4 Kd8 63. Ra7 Ke8 64. Rc7 Kf8 65. Ra7 Rh5 66. Rc7 f6 67. Kf3 Ke8 68. Rg7 Kf8 69. Rxg6 Kf7 70. Rg1 Rxh4 71. Ra1 Ke6 72. Ra5 Kd5 73. Ra6 Rh6 74. Ra8 Kd4 75. Rd8+ Kc3 76. Ke4 c4 77. Rc8 Rh5 78. Rc6 Rh6 79. Kf5 Kd3 80. Rd6+ Kc2 81. Rc6 c3 82. Rc8 Kd2 83. Rd8+ Kc1 84. Rc8 c2 85. Rc7 Rh4 86. Rc8 Kd2 87. Rd8+ Ke3 88. Re8+ Kf3 89. Rc8 Rxf4+ 90. Kg6 Rg4+ 91. Kxf6 Rg2 92. Ke5 Rd2"

