var Node = function( value, next ) {
    return {
        value: value,
        next: next
    }
}

var printListForward = function( list ) {
    if (list == null) {
        return; 
    }
    document.getElementById('output').innerHTML += '<li>' + list.value + '</li>';
    return printListForward( list.next );
}

var printListReverse = function( list ) {
    if (list == null) {
        return;
    }
    var ret = printListReverse( list.next );
    document.getElementById('output').innerHTML += '<li>' + list.value + '</li>';
    return ret;
}

var reverseList = function( list ) {
    if (list == null || list.next == null) {
           return list;
    }
    var ret = reverseList( list.next );
    
    var nextNode = list.next;
    list.next = null;
    nextNode.next = list;
    return ret;
}

var list = Node(1, Node(2, Node(3)));
//printListReverse( list );
list = reverseList( list );
printListForward( list );
